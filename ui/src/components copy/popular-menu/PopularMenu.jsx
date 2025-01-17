import React from 'react'
import { Container,Row, Col } from 'reactstrap'
import {popularMenuFood} from '../../assets/fake-data/products'
import ProductCard from '../product-card/ProductCard'
const PopularMenu = () => {
  return (
    <section className='pt-0'>
        <Container>
            <Row>
                <Col lg="12" className='mb-5'>
                    <h2>Popular food menu</h2>
                </Col>
                {
                    popularMenuFood.map((item,index)=>(
                        <Col lg='3' key={index }>
                           <ProductCard item={item}/>
                        </Col>
                    ))
                }
            </Row>
        </Container>
    </section>
  )
}

export default PopularMenu