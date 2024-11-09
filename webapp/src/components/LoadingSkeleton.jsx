import React from 'react';
import { Skeleton, Col, Row, Flex, Card } from 'antd';

const LoadingSkeleton = () => {
    var cardsCount = 9;
    var cards = [];

    for (var i = 0; i < cardsCount; i++) {
        cards.push(
            <Row key={i}>
                <Card hoverable loading className="card"></Card>
            </Row>
        );
    }

    return (
        <>
            <Flex justify="space-between" style={{ marginBottom: "25px" }}>
                <Skeleton.Input active size="large" />
                <Skeleton.Input active size="large" />
            </Flex>
            <Col className="cards-list-col">
                {cards}
            </Col>
        </>
    );
}

export default LoadingSkeleton;